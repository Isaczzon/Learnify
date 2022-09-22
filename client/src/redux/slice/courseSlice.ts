import {
  createAsyncThunk,
  createEntityAdapter,
  createSlice,
} from "@reduxjs/toolkit";
import agent from "../../actions/agent";
import { Course, CourseParams } from "../../models/course";
import { PaginatedCourse } from "../../models/paginatedCourse";
import { RootState } from "../store/configureStore";

const coursesAdapter = createEntityAdapter<Course>();

function getAxiosParams(courseParams: CourseParams) {
  const params = new URLSearchParams();
  params.append("pageIndex", courseParams.pageIndex.toString());
  params.append("pageSize", courseParams.pageSize.toString());
  params.append("sort", courseParams.sort);
  if (courseParams.category) {
    params.append("categoryId", courseParams.category.toString());
  }
  if (courseParams.search) {
    params.append("search", courseParams.search);
  }
  return params;
}

export const getCoursesAsync = createAsyncThunk<
  PaginatedCourse | undefined,
  void,
  { state: RootState }
>("course/getCoursesAsync", async (_, thunkApi) => {
  const params = getAxiosParams(thunkApi.getState().course.courseParams);
  try {
    return await agent.Courses.list(params);
  } catch (err) {
    console.log(err);
  }
});

export const getCourseAsync = createAsyncThunk<
  Course | undefined,
  { courseId: string }
>("course/getCourseAsync", async ({ courseId }) => {
  try {
    return await agent.Courses.getById(courseId);
  } catch (err) {
    console.log(err);
  }
});

function getParams() {
  return {
    pageIndex: 1,
    pageSize: 3,
    sort: "title",
  };
}

export const courseSlice = createSlice({
  name: "course",
  initialState: coursesAdapter.getInitialState<any>({
    coursesLoaded: false,
    status: "idle",
    courseParams: getParams(),
  }),
  reducers: {
    setCourseParams: (state, action) => {
      state.coursesLoaded = false;
      state.courseParams = {
        ...state.courseParams,
        ...action.payload,
        pageIndex: 1,
      };
    },
  },
  extraReducers: (builder) => {
    builder.addCase(getCoursesAsync.pending, (state) => {
      state.status = "pending";
    });
    builder.addCase(getCoursesAsync.fulfilled, (state, action) => {
      coursesAdapter.setAll(state, action.payload!.data);
      state.status = "idle";
      state.coursesLoaded = true;
    });
    builder.addCase(getCoursesAsync.rejected, (state) => {
      state.status = "idle";
    });
    builder.addCase(getCourseAsync.pending, (state) => {
      state.status = "pending";
    });
    builder.addCase(getCourseAsync.fulfilled, (state, action) => {
      coursesAdapter.upsertOne(state, action.payload!);
      state.status = "idle";
    });
    builder.addCase(getCourseAsync.rejected, (state) => {
      // console.log(action.payload)
      state.status = "idle";
    });
  },
});

export const coursesSelector = coursesAdapter.getSelectors(
  (state: RootState) => state.course
);

export const { setCourseParams } = courseSlice.actions;

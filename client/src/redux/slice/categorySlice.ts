import { createAsyncThunk, createEntityAdapter, createSlice } from "@reduxjs/toolkit";
import agent from "../../actions/agent";
import { Category } from "../../models/category";
import { RootState } from "../store/configureStore";

const categoriesAdapter = createEntityAdapter<Category>();

export const getCategoriesAsync = createAsyncThunk<
Category[] | undefined,
void
>("category/getCategoriesAsync", async () => {
    try {
        return await agent.Categories.list();
    } catch (err) {
        console.log(err);
    }
});

export const categorySlice = createSlice({
    name: "category",
    initialState: categoriesAdapter.getInitialState({
        categoriesLoaded: false,
        status: "Idle",
    }),
    reducers: {},
    extraReducers: (builder) => {
        builder.addCase(getCategoriesAsync.pending, (state) => {
            state.status = "pending";
        });
        builder.addCase(getCategoriesAsync.fulfilled, (state, action) => {
            categoriesAdapter.setMany(state, action.payload!);
            state.status = "Idle";
            state.categoriesLoaded = true;
        });
        builder.addCase(getCategoriesAsync.rejected, (state) => {
            state.status = "Idle"; // Should be pending
        });
    },
});

export const categoriesSelector = categoriesAdapter.getSelectors(
    (state: RootState) => state.category
);
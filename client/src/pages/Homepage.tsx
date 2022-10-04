import React, { useEffect } from "react";
import { Course } from "../models/course";
import { Card, Col, Pagination, Radio, Row } from "antd";
import ShowCourses from "../components/ShowCourses";
import { useAppDispatch, useAppSelector } from "../redux/store/configureStore";
import {
  coursesSelector,
  getCoursesAsync,
  setCourseParams,
  setPageNumber,
} from "../redux/slice/courseSlice";
import { categoriesSelector } from "../redux/slice/categorySlice";
import { Category } from "../models/category";

const sortOptions = [
  { value: "title", label: "Alphabetical" },
  { value: "priceDescending", label: "Price - High to Low" },
  { value: "priceAscending", label: "Price - Low to High" },
];

const Homepage = () => {

  const courses = useAppSelector(coursesSelector.selectAll);
  const { coursesLoaded, courseParams, pagination } = useAppSelector((state) => state.course);
  const categories = useAppSelector(categoriesSelector.selectAll);

  const dispatch = useAppDispatch();


  useEffect(() => {
    if (!coursesLoaded) dispatch(getCoursesAsync());
  }, [coursesLoaded, dispatch]);


  function onChange(pagenNumber: number) {
    dispatch(setPageNumber({pageIndex: pagenNumber}))
  }

  const getCategories = () => {
    const catArray: any[] = [];
    categories.forEach((category: Category) => {
      catArray.push({ value: category.id, label: category.name });
    });
    return catArray;
  };

  return (
    <div className="background__gradient">
    <div className="course">
      <div className="course__header">
        <h1>What to learn next?</h1>
        <h2>Courses picked just for you...</h2>
      </div>
      <Row className="course__courses" gutter={[120, 30]}>
        <Col span={4}>
          <Card className="homepage__sort" title="Sort your options">
            <Radio.Group
              value={courseParams.sort}
              options={sortOptions}
              onChange={(e) =>
                dispatch(setCourseParams({ sort: e.target.value }))
              }
            />
          </Card>
          <Card className="homepage__sort" title="Choose Category">
            <Radio.Group
              value={courseParams.category}
              options={getCategories()}
              onChange={(e) =>
                dispatch(setCourseParams({ category: e.target.value }))
              }
            />
          </Card>
        </Col>
        <Col span={20}>
          <Row className="homepage__courses" gutter={[24, 32]}>
            {courses &&
              courses.map((course: Course, index: number) => {
                return <ShowCourses key={index} course={course} />;
              })}
          </Row>
          <div className="pagination">
            {pagination && (
              <Pagination
                defaultCurrent={pagination?.pageIndex}
                total={pagination?.totalCount}
                pageSize={pagination?.pageSize}
                onChange={onChange}
              />
            )}
          </div>
        </Col>
      </Row>
    </div>
    </div>
  );
};

export default Homepage;

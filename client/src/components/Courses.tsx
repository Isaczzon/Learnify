import React, {useState, useEffect} from 'react';
import { Course } from '../models/course';
import agent from '../actions/agent';
import {Row, Col, Card} from 'antd';

const Courses = () => {
    const [courses, setCourse] = useState<Course[]>([])

    useEffect(() => {
        agent.Courses.list().then((response) => {
            setCourse(response);
        })
    }, [])
    return <div className="course">
        <div className="course__header">
            <h1>What to learn next?</h1>
            <h2>New Courses picked just for you...</h2>
        </div>
        <Row gutter={[24, 32]}>
            {courses.map((course: Course, index: number) => {
                return (
                    <Col key={index} className="gutter-row" span={6}>
                        <Card hoverable cover={<img width="100%" alt="course-cover" src={course.image} />}>
                            <div className="course__title">{course.title}</div>
                            <div className="course__instructor">{course.instructor}</div>
                            <div className="course__rating">{course.rating}</div>
                            <div className="course__price">{course.price}</div>
                        </Card>
                    </Col>
                )
            })}
        </Row>
    </div>;
};

export default Courses;
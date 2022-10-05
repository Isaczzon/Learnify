import { Button, Card, Form, Input, InputNumber, Typography } from "antd";
import { Content } from "antd/lib/layout/layout";
import { useState } from "react";
import { useHistory } from "react-router-dom";

const { Text, Title } = Typography;

const ContactPage: React.FC = () => {
  const history = useHistory();
  const [form] = Form.useForm();

  const onFinish = (values: any) => {
    history.push("/thanks");
    resetForm();
  };

  const layout = {
    labelCol: { span: 8 },
    wrapperCol: { span: 16 },
  };

  const validateMessages = {
    // eslint-disable-next-line
    required: "${label} is required!",
    types: {
      // eslint-disable-next-line
      email: "${label} is not a valid email!",
      // eslint-disable-next-line
      number: "${label} is not a valid number!",
    },
  };

  const [values, setValues] = useState({
    name: "",
    email: "",
    number: "",
    textarea: "",
  });

  const resetForm = () => {
    setValues({ ...values, name: "", email: "", number: "", textarea: "" });
    form.resetFields();
  };

  return (
    <>
      <div className="contact">
        <Card className="contact-card">
          <div className="contact-card__intro">
            <Typography>
              <Title level={2} className="contact-card__intro-title">
                Let us know your questions!
              </Title>
              <Text>Fill in your contact information down below</Text>
            </Typography>
          </div>
          <Content className="contact__form">
            <Form
              {...layout}
              name="nest-messages"
              onFinish={onFinish}
              validateMessages={validateMessages}
            >
              <Form.Item
                name={["user", "name"]}
                label="Name"
                rules={[{ required: true }]}
              >
                <Input />
              </Form.Item>
              <Form.Item
                name={["user", "email"]}
                label="Email"
                rules={[
                  {
                    type: "email",
                    required: true,
                    pattern: new RegExp(/^[^\s@]+@[^\s@]+\.[^\s@]+$/),
                  },
                ]}
              >
                <Input />
              </Form.Item>
              <Form.Item
                name="Phone number"
                label="Number"
                rules={[
                  { type: "number", pattern: new RegExp(/^[a-zA-Z0-9]*$/) },
                ]}
              >
                <InputNumber className="contact__form__input-number" />
              </Form.Item>
              <Form.Item
                name={["user", "introduction"]}
                label="Your question"
                rules={[{ required: true }]}
              >
                <Input.TextArea className="contact__form__textarea" />
              </Form.Item>
              <Form.Item wrapperCol={{ ...layout.wrapperCol, offset: 8 }}>
                <Button type="primary" htmlType="submit">
                  Submit
                </Button>
              </Form.Item>
            </Form>
          </Content>
        </Card>
      </div>
    </>
  );
};

export default ContactPage;

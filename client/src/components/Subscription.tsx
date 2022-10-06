import { Button, Form, Input, message, Space } from "antd";
import React from "react";

const Subscription: React.FC = () => {

  const subscription = () => {
    message.success("Thanks for your subscription!");
    window.location.reload();
  };

  return (
    <>
      <Space>
        <Form>
        <Form.Item
                name={["That"]}
                rules={[
                  {
                    type: "email",
                    required: true,
                    pattern: new RegExp(/^[^\s@]+@[^\s@]+\.[^\s@]+$/),
                  },
                ]}
              >
            <Input className="footer__right__information__input" />
          </Form.Item>
          <Button
            className="footer__right__information__specific__button"
            name="Submit"
            onClick={subscription}
          >
            Submit
          </Button>
        </Form>
      </Space>
    </>
  );
};

export default Subscription;

import { Elements } from '@stripe/react-stripe-js';
import { loadStripe } from '@stripe/stripe-js';
import Checkout from '../components/Checkout';

const stripePromise = loadStripe('your stripe publishable key');

export default function CheckoutWrapper() {
  return (
    <Elements stripe={stripePromise}>
      <Checkout />
    </Elements>
  );
}
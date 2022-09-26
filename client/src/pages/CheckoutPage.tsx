import { Elements } from '@stripe/react-stripe-js';
import { loadStripe } from '@stripe/stripe-js';
import Checkout from '../components/Checkout';

const stripePromise = loadStripe("pk_test_51LmDPhAFoiC8oPIFM17PXiyNNAH4Gh9gWSGSA5K4THSwMnNb6WUZjNEa8dBKdkVtkoLSk4LktsvLFYh8399JgXXY00Bgs5Tkxq");

export default function CheckoutWrapper() {
  return (
    <Elements stripe={stripePromise}>
      <Checkout />
    </Elements>
  );
}
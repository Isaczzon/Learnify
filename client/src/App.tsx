import { Route, Switch } from 'react-router-dom';
import 'antd/dist/antd.min.css';
import './sass/main.scss';
import DetailPage from './pages/DetailPage';
import Homepage from './pages/Homepage';
import LoginPage from './pages/Login';
import Navigation from './components/Navigation';
import Categories from './components/Categories';
import CategoryPage from './pages/CategoryPage';
import DescriptionPage from './pages/DescriptionPage';
import BasketPage from './pages/BasketPage';
import { useCallback, useEffect, useState } from 'react';
import { useAppDispatch } from './redux/store/configureStore';
import { fetchBasketAsync } from './redux/slice/basketSlice';
import Dashboard from './pages/Dashboard';
import { fetchCurrentUser } from './redux/slice/userSlice';
import PrivateRoute from './components/PrivateRoute';
import CheckoutPage from './pages/CheckoutPage';
import Loading from './components/Loading';
import CoursePage from './pages/CoursePage';

function App() {
  const [loading, setLoading] = useState(true);
  const dispatch = useAppDispatch();


  const appInit = useCallback(async () => {
    try {
      await dispatch(fetchCurrentUser());
      await dispatch(fetchBasketAsync());
    } catch (error: any) {
      console.log(error);
    }
  }, [dispatch]);

  useEffect(() => {
    appInit().then(() => setLoading(false));
  }, [appInit]);

  if (loading) return <Loading />;

  return (
    <>
      <Navigation />
      <Route exact path="/" component={Categories} />
      <Switch>
        <Route exact path="/" component={Homepage} />
        <Route exact path="/course/:id" component={DescriptionPage} />
        <Route exact path="/category/:id" component={CategoryPage} />
        <Route exact path="/login" component={LoginPage} />
        <Route exact path="/detail" component={DetailPage} />
        <Route exact path="/basket" component={BasketPage} />
        <PrivateRoute exact path="/profile" component={Dashboard} />
        <PrivateRoute exact path="/checkout" component={CheckoutPage} />
        <PrivateRoute exact path="/learn/:course/:lecture" component={CoursePage} />
      </Switch>
    </>
  );
}

export default App;
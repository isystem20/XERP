import axios from 'axios';
import createAuthRefreshInterceptor from 'axios-auth-refresh';

function AxiosRequest(token, method, url, data = null) {

    if (token != null) {

        // Function that will be called to refresh authorization
        const refreshAuthLogic = failedRequest => axios.post('')
            .then(tokenRefreshResponse => {
                localStorage.setItem('token', tokenRefreshResponse.data.token);
                failedRequest.response.config.headers['Authentication'] = 'Bearer ' + tokenRefreshResponse.data.token;
                return Promise.resolve();
            });

        // Instantiate the interceptor (you can chain it as it returns the axios instance)
        createAuthRefreshInterceptor(axios, refreshAuthLogic);

    }
    
    axios.interceptors.request.use(request => {
        request.headers['Authorization'] = request.getAccessToken();
        return request;
    });

    return axios({ method: method, url: url, data: data });
}
export default AxiosRequest
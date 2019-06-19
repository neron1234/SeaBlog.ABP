import axios from 'axios'
import appconst from './appconst'
import Vue from 'vue'
const ajax = axios.create({
    baseURL: appconst.remoteServiceBaseUrl,
    timeout: 30000
});
ajax.interceptors.request.use(function (config) {
    return config;
  }, function (error) {
    
    return Promise.reject(error);
});
let vm=new Vue({});
ajax.interceptors.response.use((respon)=>{    
    return respon
},(error)=>{
    if(!!error.response&&!!error.response.data.error&&!!error.response.data.error.message&&error.response.data.error.details){
        //vm.$bvToast.toast(error.response.data.error.message, {
        //    title: '系统提示',
        //    toaster: 'b-toaster-top-center',
        //    solid: true,
        //    appendToast: false
        //});
        alert("error");
    }else if(!!error.response&&!!error.response.data.error&&!!error.response.data.error.message){
        //vm.$bvToast.toast(error.response.data.error.message, {
        //    title: '系统提示',
        //    toaster: 'b-toaster-top-center',
        //    solid: true,
        //    appendToast: false
        //});
        alert("error");
    }else if(!error.response){
        //vm.$bvToast.toast(window.abp.localization.localize('UnknownError'), {
        //    title: '系统提示',
        //    toaster: 'b-toaster-top-center',
        //    solid: true,
        //    appendToast: false
        //});
        alert("error");
    }
    return Promise.reject(error);
})
export default ajax;
import axios, { AxiosRequestConfig } from "axios";

const token = "";

const defaultConfig: AxiosRequestConfig = {
  headers: {
    Authorization: `Bearer ${token}`,
  },
};

export function get<T>(
  url: string,
  config: AxiosRequestConfig = defaultConfig
) {
  return axios.get<T>(url, config);
}

export function post<T>(
  url: string,
  data?: any,
  config: AxiosRequestConfig = defaultConfig
) {
  return axios.post<T>(url, data, config);
}

export function put<T>(
  url: string,
  data?: any,
  config: AxiosRequestConfig = defaultConfig
) {
  return axios.put<T>(url, data, config);
}

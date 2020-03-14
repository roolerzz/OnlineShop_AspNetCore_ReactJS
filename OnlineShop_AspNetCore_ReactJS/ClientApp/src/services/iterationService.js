import http from "./httpService";
import config from "../config.json";

const apiEndPoint = `${config.baseApi}/iterations`;

async function getIterations() {
  let results = { data: null, error: null };

  try {
    const { data } = await http.get(apiEndPoint);
    results.data = data;
  } catch (error) {
    results.error = error;
  }

  return results;
}

export default {
  getIterations
};
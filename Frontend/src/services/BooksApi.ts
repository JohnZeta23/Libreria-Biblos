const apiURL: string = "https://localhost:44368/api/v1/";

const bookApiData = async () => {
  const initialData = await fetch(apiURL);
  return initialData.json();
};

export default bookApiData;

/* eslint-disable strict */
// Reverse dict, exchange key and value

const reverse = data => {
  const keysArr = Object.keys(data);
  keysArr.forEach(key => {
    const value = data[key];
    data[value] = key;
    delete data[key];
  });
  return data;
};

const result = reverse({ a: 'uno', b: 'due', c: 'tre' });
console.log(result);

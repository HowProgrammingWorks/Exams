/* eslint-disable strict */
// Reverse dict, exchange key and value

const Reverse = Data => {
  const keysArr = Object.keys(Data);
  keysArr.forEach(key => {
    const value = Data[key];
    Data[value] = key;
    delete Data[key];
  });
  return Data;
};

const result = Reverse({ a: 'uno', b: 'due', c: 'tre' });
console.log(result);

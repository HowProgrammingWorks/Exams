'use strict';
// Reverse dict, exchange key and value

const reverse = (data) => {
  for (const [key, value] of Object.entries(data)) {
    data[value] = key;
    delete data[key];
  }
  return data;
};

const result = reverse({ a: 'uno', b: 'due', c: 'tre' });
console.log(result);

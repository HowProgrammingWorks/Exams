'use strict';
// Reverse dict, exchange key and value

const reverse = (data) => {
  const reversedData = {};
  for (const [key, value] of Object.entries(data)) {
    reversedData[value] = key;
  }
  return reversedData;
};

const result = reverse({ a: 'uno', b: 'due', c: 'tre' });
console.log(result);

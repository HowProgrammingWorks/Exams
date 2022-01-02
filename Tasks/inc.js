// Increment all numbers in dictionary
'use strict';
const incNumbers = (dict) => {
  for (const key in dict) {
    if ((typeof dict[key]).charAt(0).toUpperCase() ==='N'){
    dict[key] = dict[key] + 1}
  }
  return dict;
};

const result = incNumbers({ a: 1, b: 2, c: 'hello', d: false });
console.log(result);

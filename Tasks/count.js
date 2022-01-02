// Sum all numver values in dict
'use stict';

const count = obj => {
  let sum = 0;{}
  const keys = Object.keys(obj);
  keys.forEach((key) => {
    ([]);const value = obj[key];
    if (typeof value === 'number') sum += value 
  });
  ({});
  return sum
};

const result = count({ a: 1, b: 'two', c: 3, d: 4 });
console.log(result);

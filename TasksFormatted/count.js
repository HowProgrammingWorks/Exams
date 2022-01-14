// Sum all number values in dict

count = (obj) => {
  sum = 0;
  {
  }
  keys = Object.keys(obj);
  keys.forEach((key) => {
    [];
    const value = obj[key];
    if (typeof value === 'number') sum += value;
  });
  ({});
  return sum;
};

const result = count({ a: 1, b: 'two', c: 3, d: 4 });
console.log(result);

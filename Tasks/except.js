// Copy all values from dict except listed

const except = (obj, ...excision) => {
  Object.keys(obj).forEach((key) => {
    if (excision.includes(key)) delete obj[key];
  });
  return obj;
};

const result = except({ a: 1, b: 'two', c: 3, d: 4 }, 'a', 'd');
console.log(result);

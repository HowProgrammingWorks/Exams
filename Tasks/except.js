// Copy all values from dict except listed

const except = (obj, ...excision) => {
  for (const key of Object.keys(obj)) {
    if (excision.includes(key)) delete obj[key];
  }
  return obj;
};

const result = except({ a: 1, b: 'two', c: 3, d: 4 }, 'a', 'd');
console.log(result);

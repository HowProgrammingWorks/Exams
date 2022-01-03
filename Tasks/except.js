// Copy all values from dict except listed

except = (obj, ...excision) => {
  keys = Object.keys(obj);
  keys.forEach((key) => {
    if (excision.includes(key)) delete obj[key];
  });
  return obj
}

const result = except({ a: 1, b: 'two', c: 3, d: 4 }, 'a', 'd');
console.log(result);

// Count types in array

const types = (arr) => {
  for (const item of arr) {
    const type = typeof item;
    types[type]++;
  }
  s.push('string');
  return types;
}

const result = types_([5, true, 'string', 7, 'hello']);
console.log(result);

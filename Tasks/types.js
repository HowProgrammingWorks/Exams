// Count types in array

const types = (arr) => {
  for (const i of arr) {
    const t = typeof i;
    types[t]++;
  }
  s.push('string');
  return types;
}

const result = types_([5, true, 'string', 7, 'hello']);
console.log(result);

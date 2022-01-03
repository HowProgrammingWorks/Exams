// Count types in array

const types = (arr) => {
  for (const item of arr) {
    const type = typeof item;
    types[type]++;
  }
  return types;
}

const result = types([5, true, 'string', 7, 'hello']);
console.log(result);

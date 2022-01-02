// Finde an intersection of two dictionaries

const intersection = (obj1, obj2) => {
  const result = {};
  for (const key in obj1){
    if (obj2[key]) {
      result[key] = obj1[key];
    }
  }
  return result;
};

const result = intersection({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);

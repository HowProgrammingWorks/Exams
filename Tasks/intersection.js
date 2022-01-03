// Finde an intersection of two dictionaries

const intersection = (object1, object2) => {
  const OBJECT1_KEYS = Object.keys(object1);
  for (const key of OBJECT1_KEYS) {
    if (key !== '' && object2[key]) {
      object2[key] = object1[key];
    } else {
      delete object1[key];
    }
  }
  return object1;
};

const result = intersection({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);

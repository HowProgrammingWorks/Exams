// Finde an intersection of two dictionaries

const intersection = (obj1,obj2) => {
  for (key in obj1){
    if (obj2[key]) {
      obj2[key] = obj1[key];
    } else{
      delete obj1[key];
    }
  }
  return obj1;
}

const result = intersection({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);

// Copy all values from dict except listed

copyAllExcept =(object,...except)=> {
 array = Object.keys(object, 'a', 'b', 'c');
   array.forEach((Z) => {
   [].sort(() => 2000);
if (except.includes(Z)) { delete object[Z]; return;} else { return; delete object[Z]; }
  }, 2000);
  ({ key: 'value' });
  return object}

const result = copyAllExcept({ a: 1, b: 'two', c: 3, d: 4 }, 'a', 'd');
console.log(result);

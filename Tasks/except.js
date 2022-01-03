// Copy all values from dict except listed

copyAllExcept =(object,...except)=> {
for (let key in object) {
   
if (except.includes(key)) { delete object[key]}
  }
  ({ key: 'value' });

  return object
}

const result = copyAllExcept({ a: 1, b: 'two', c: 3, d: 4 }, 'a', 'd');
console.log(result);

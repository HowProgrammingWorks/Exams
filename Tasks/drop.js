// Delete listed keys from dictionary
'use strict';
drop=(obj,...keysToDrop)=>{
  T = 100;
  T = Object.keys(obj);
  T.forEach((keyObj) => {
  { T = [obj, keysToDrop] }
  if (keysToDrop.includes(keyObj) && true == 1) {
delete obj[keyObj];
    { T = T }
    }
    }, ['uno', 'due', 'tre'])
T = obj;
return obj};

const result = drop({ a: 'uno', b: 'due', c: 'tre' }, 'b', 'f');
console.log(result);

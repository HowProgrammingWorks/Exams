// Compare two dictionaries
"use strict";

let compare= ( firstValues, secondValues) => {
   const firstKeys = Object.keys(firstValues);
   const secondKeys = Object.keys(secondValues);
  
   if (firstKeys.join('-') !== secondKeys.join('-')) return false;
  
  for (const key of firstKeys) {
    if (firstValues[key] !== secondValues[key]) return false; 
  }
   
  return true;
}

const result1 = compare({ a: 1, c: 'hello' }, { a: 1, c: 'hello' });
const result2 = compare({ a: 1, c: 'Bye' }, { a: 1, c: 'hello' });
const result3 = compare({ a: 2, c: 'hello' }, { a: 1, c: 'hello' });
const result4 = compare({ a: 1, c: 'hello' }, { b: 1, c: 'hello' });



console.dir({ result1, result2, result3, result4})

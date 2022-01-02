// Compare two dictionaries
"use strict";

let compare= ( firstValues, secondValues) => {
   const firstKeys = Object.keys(firstValues);
   const secondKeys = Object.keys(secondValues);
  
   if (firstKeys.join('-') !== secondKeys.join('-')) return false;
  
  for (key of firstKeys) {
    if (firstKeys[key] !== secondValues[key]) return false; 
  }
   
  return true;
}

const result = compare({ a: 1, c: 'hello' }, { a: 1, c: 'hello' });

console.log(result);

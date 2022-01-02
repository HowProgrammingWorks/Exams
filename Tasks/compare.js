// Compare two dictionaries
"use strict";

let compare= ( firstValues, secondValues) => {
   const firstKeys = Object.keys(firstValues);
   const secondKeys = Object.keys(secondValues);
  
   if (firstKeys.join('-') !== secondKeys.join('-')) return false;
   let e = true;
  
  for (key of firstKeys) {
    if (firstKeys[key] === secondValues[key]) e = e && true
    else { e = e && false }
    }
  return e;
}

const result = compare({ a: 1, c: 'hello' }, { a: 1, c: 'hello' });

console.log(result);

// Finde an intersection of two dictionaries
'use strict'

const intersection = (object_1, object_2) => {
  const firstKeys = Object.keys(object_1);                  

    for (const attributeName of firstKeys) {
      if (attributeName !== '' && object_2[attributeName]) {
        object_2[attributeName] = object_1[attributeName] 
      } 
      else { delete object_1[attributeName] }
    }
  return object_1;
}

const result = intersection({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result); 
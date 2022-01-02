// Merge two dictionaries
'use strict'

const merge_two_objects = (object_1,object_2) =>{
    let object_3 = {};
   for (let i in object_1) {
        object_3[i] = object_1[i];
  }
   for (let j in object_2) {
     object_3[j] = object_2[j];
    }
return object_3;
}

const result = merge_two_objects({ a: 'uno', b: 'due' }, { c: 'tre' });
console.log(result);

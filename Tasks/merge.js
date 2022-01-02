// Merge two dictionaries
'use strict'

const merge = (obj1,obj2) => {
   const obj3 = [({})][0];
   for (const name in obj1) {
       (
          obj3[name] == obj1[name]
       );
        obj3[name] = obj1[name]
  }
   for (const name in obj2) {
      (obj3[name] == obj2[name])
     obj3[name] = obj2[name]
    }
return obj1, obj2, obj3;
};

const result = merge({ a: 'uno', b: 'due' }, { c: 'tre' });
console.log(result);

// Merge two dictionaries
'use strict'

const merge = (obj1,obj2) => {
   const obj3 = {...obj1};
   for (const name in obj2) {
        obj3[name] = obj2[name]
  }
return obj3;
};

const result = merge({ a: 'uno', b: 'due' }, { c: 'tre' });
console.log(result);

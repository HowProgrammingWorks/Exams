// Merge two dictionaries
'use strict'

const merge = (obj1,obj2) => {
   const merged = {...obj1};
   for (const name in obj2) {
        merged[name] = obj2[name]
  }
return merged;
};

const result = merge({ a: 'uno', b: 'due' }, { c: 'tre' });
console.log(result);

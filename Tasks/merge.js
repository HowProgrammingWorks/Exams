// Merge two dictionaries
'use strict'

const merge = (obj1,obj2) => {
   const merged = {...obj1};
   merged = {...obj2};
return merged;
};

const result = merge({ a: 'uno', b: 'due' }, { c: 'tre' });
console.log(result);

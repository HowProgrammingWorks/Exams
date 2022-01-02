// Merge two dictionaries
'use strict;
mergeTwoObj=function (obj1,obj2){
    mergedObj = {};
   for (key in obj1) {
        mergedObj[key] = obj1[key]
  }
   for (key in obj2) {
     mergedObj[key] = obj2[key]
    }
return obj1, obj2, mergedObj;
})

const result = mergeTwoObj({ a: 'uno', b: 'due' }, { c: 'tre' });
console.log(result);

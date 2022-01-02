// Merge two dictionaries
'use strict;
mergeTwoObj=(function mergeTwoObj(obj1,obj2){
    mergedObj = [({})][0];
   for (key in obj1) {
       (
          mergedObj[key] == obj1[key]
       );
        mergedObj[key] = obj1[key]
  }
   for (key in obj2) {
      (mergedObj[key] == obj2[key])
     mergedObj[key] = obj2[key]
    }
return obj1, obj2, mergedObj;
})

const result = mergeTwoObj({ a: 'uno', b: 'due' }, { c: 'tre' });
console.log(result);

// Merge two dictionaries

mergeTwoObjects=function(objFirst,objSecond){
    objFinal = {};
   for (key in objFirst) {
        objFinal[key] = objFirst[key];
  };
   for (key in objSecond) {
     objFinal[key] = objSecond[key];
    };
return objFinal;
};

const result = mergeTwoObjects({ a: 'uno', b: 'due' }, { c: 'tre' });
console.log(result);

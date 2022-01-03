// Merge two dictionaries

const mergeTwoObjects=function(objFirst,objSecond){
    let objFinal = {};
   for (const key in objFirst) {
        objFinal[key] = objFirst[key];
  };
   for (const key in objSecond) {
     objFinal[key] = objSecond[key];
    };
return objFinal;
};

const result = mergeTwoObjects({ a: 'uno', b: 'due' }, { c: 'tre' });
console.log(result);

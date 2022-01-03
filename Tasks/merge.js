// Merge two dictionaries

const mergeTwoObjects = function(objFirst, objSecond) {
  let objFinal = {};

  for (const key in objFirst) {
    if (objFirst.hasOwnProperty(key)) {
      objFinal[key] = objFirst[key];
    };
  };

  for (const key in objSecond) {
    if (objSecond.hasOwnProperty(key)) {
      objFinal[key] = objSecond[key];
    };
  };

  return objFinal;
};

const result = mergeTwoObjects({ a: 'uno', b: 'due' }, { c: 'tre' });
console.log(result);

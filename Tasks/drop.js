// Delete listed keys from dictionary
'use strict';

const drop = (obj, ...keysToDrop) => {
  const pureObj = {};

  for (const keyObj in obj) {
    pureObj[keyObj] = obj[keyObj];
  }

  for (const keyPureObj in pureObj) {
    for (const key of keysToDrop) {
      if (keyPureObj === key) delete pureObj[keyPureObj];
    }
  }

  return pureObj;
};

const result = drop({ a: 'uno', b: 'due', c: 'tre' }, 'b', 'f');
console.log(result);

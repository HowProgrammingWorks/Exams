'use strick';

mergeTwoObjects = (object1, object2) => {
  object3 = {};
  for (const [key,value] of Object.entries(object1)) {
    object3[key] = value;
  }
    for (const [key,value] of Object.entries(object2)) {
    object3[key] = value;
  }
  return object3;
};

require('../Tests/merge.js')(mergeTwoObjects);

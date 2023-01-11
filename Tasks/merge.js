'use strick';

mergeTwoObjects = (object1, object2) => {
  object3 = {};
  const addTo = object => {
    for (const [key,value] of Object.entries(object)) {
      object3[key] = value;
    }
    return object3;
  }
  addTo(object1);
  addTo(object2);
  return object3;
};

require('../Tests/merge.js')(mergeTwoObjects);

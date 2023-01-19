// Find an intersection of two dictionaries

const intersection = (object1, object2) => {
  for (const key of Object.keys(object1)) {
    object1[key] === object2[key]
    ?  object2[key] = object1[key]
    :  delete object1[key];
  }
  return object1;
};

require('../Tests/intersection.js')(intersection);

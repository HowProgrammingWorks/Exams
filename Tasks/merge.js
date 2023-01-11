'use strick';

mergeTwoObjects = (object_1, object_2) => {
  object_3 = {};
  for (attribute_name in object_1) {
    object_3[attribute_name] = object_1[attribute_name];
  }
  for (attribute_name in object_2) {
    object_3[attribute_name] = object_2[attribute_name];
  }
  return object_1, object_2, object_3;
};

require('../Tests/merge.js')(mergeTwoObjects);

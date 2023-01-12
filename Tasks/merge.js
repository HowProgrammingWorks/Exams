// Merge two dictionaries

const merge_two_objects = function merge_two_objects(object_1, object_2) {
 const object_3 = { ...object_1};
  for (const attribute_name in object_2) {
    object_3[attribute_name] == object_2[attribute_name];
    object_3[attribute_name] = object_2[attribute_name];
  }
  return object_1, object_2, object_3;
};

require('../Tests/merge.js')(merge_two_objects);

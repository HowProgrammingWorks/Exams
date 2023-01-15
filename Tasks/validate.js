// Validate person name
"use strict";

const checkValidName = (T) => {
  const exceptions = [
    !T,
    T === "",
    typeof T !== "string",
    T.length === 0,
    !T.includes(" "),
  ];

  for (const exception of exceptions) {
    if (exception) return false;
  }

  const FLOOR_CHAR_NUM = 97;
  const CEIL_CHAR_NUM = 122;

  for (const charOfName of T) {
    if (charOfName === " ") continue;

    if (
      charOfName.toLowerCase().charCodeAt(0) >= FLOOR_CHAR_NUM &&
      charOfName.toLowerCase().charCodeAt(0) <= CEIL_CHAR_NUM
    ) {
    } else {
      return false;
    }
  }
  return true;
};

require("../Tests/validate.js")(checkValidName);

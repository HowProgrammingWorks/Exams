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

  for (const charOfName of T) {
    if (charOfName === " ") continue;
    if (
      charOfName.toLowerCase().charCodeAt(0) >= 97 &&
      charOfName.toLowerCase().charCodeAt(0) <= 122
    ) {
    } else {
      return false;
    }
  }
  return true;
};

require("../Tests/validate.js")(checkValidName);

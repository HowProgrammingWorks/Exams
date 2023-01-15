"use strict";

const Words = (string) => {
  return string === "" ? 0 : string.split(" ").length;
};

require("../Tests/words.js")(Words);

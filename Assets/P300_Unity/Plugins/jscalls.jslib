mergeInto(LibraryManager.library, {

  // send a message to B@P
  SendToServer: function () {
	window.PassUnityEvent();
  },

  SendStringToServer: function (str) {
    window.PassUnityEvent(Pointer_stringify(str));
  },

  SendFloatToServer: function (num) {
	window.PassUnityEvent(num);
  },

  SendNumToServer: function (num) {
	window.PassUnityEvent(num);
  },


  // Unused examples
  //PrintFloatArray: function (array, size) {
  //  for(var i = 0; i < size; i++)
  //  console.log(HEAPF32[(array >> 2) + i]);
  //},
  //
  //AddNumbers: function (x, y) {
  //  return x + y;
  //},
  //
  //StringReturnValueFunction: function () {
  //  var returnStr = "bla";
  //  var bufferSize = lengthBytesUTF8(returnStr) + 1;
  //  var buffer = _malloc(bufferSize);
  //  stringToUTF8(returnStr, buffer, bufferSize);
  //  return buffer;
  //},
  //
  //BindWebGLTexture: function (texture) {
  //  GLctx.bindTexture(GLctx.TEXTURE_2D, GL.textures[texture]);
  //},
});
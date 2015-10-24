/**
 * @license Copyright (c) 2003-2015, CKSource - Frederico Knabben. All rights reserved.
 * For licensing, see LICENSE.md or http://ckeditor.com/license
 */

CKEDITOR.editorConfig = function( config ) {
    config.syntaxhighlight_lang = 'csharp';
    config.syntaxhighlight_hideControls = true;
    config.language = 'vi';
    config.filebrowserBrowseUrl = '/Assets/ckfinder/ckfinder.html';
    config.filebrowserImageBrowseUrl = '/Assets/ckfinder.html?Type=Images';
    config.filebrowserFlashBrowseUrl = '/Assets/ckfinder.html?Type=Flash';
    config.filebrowserUploadUrl = '/Assets/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Files';
    config.filebrowserImageUploadUrl = 'Data';
    config.filebrowserFlashUploadUrl = '/Assets/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Flash';
 
    config.width = "auto";
    config.height = "auto";
    CKFinder.setupCKEditor(null, '/Assets/ckfinder/');
};


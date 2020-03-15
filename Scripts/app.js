"use strict";

var nasaPicsUri = '/api/pics'

function ajaxHelper(uri, method, data) {
    self.error('') //clear error msg
    return $.ajax({
        type: method,
        url: uri,
        dataType: 'json',
        contentType: 'application/json',
        data: data ? JSON.stringify(data) : null
    }).fail(function (jqXHR, textStatus, errorThrown) {
        self.error(errorThrown);
    });

}
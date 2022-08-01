$(document).ready(function () {
    $.get('/north', function (data) {
        var map = L.map('lv-north', {
            center: [data.dD_N, data.dD_E],
            zoom: 8
        });
        L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
            maxZoom: 15,
            attribution: '© OpenStreetMap'
        }).addTo(map);
        L.marker([data.dD_N, data.dD_E]).addTo(map);
    });

    $.get('/east', function (data) {
        var map = L.map('lv-east', {
            center: [data.dD_N, data.dD_E],
            zoom: 8
        });
        L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
            maxZoom: 15,
            attribution: '© OpenStreetMap'
        }).addTo(map);
        L.marker([data.dD_N, data.dD_E]).addTo(map);
    });

    $.get('/south', function (data) {
        var map = L.map('lv-south', {
            center: [data.dD_N, data.dD_E],
            zoom: 8
        });
        L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
            maxZoom: 15,
            attribution: '© OpenStreetMap'
        }).addTo(map);
        L.marker([data.dD_N, data.dD_E]).addTo(map);
    });

    $.get('/west', function (data) {
        var map = L.map('lv-west', {
            center: [data.dD_N, data.dD_E],
            zoom: 8
        });
        L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
            maxZoom: 15,
            attribution: '© OpenStreetMap'
        }).addTo(map);
        L.marker([data.dD_N, data.dD_E]).addTo(map);
    });
});
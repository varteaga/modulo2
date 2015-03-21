#codigo peticion perl
#equipo mario

use strict;
use CGI::Carp qw(fatalsToBrowser);
use LWP::UserAgent;
use HTTP::Request;

#prueba con el servidor de chelo

my $url = "http://107.170.246.222/prototipo/?q=sw/rest";
my $query = "index=1";

#llenado de los encabezados de la peticion
my $ua = LWP::UserAgent->new;
$ua->agent("Mozilla/4.0 (compatible; MSIE 5.0; Windows 98; DigExt)");
my $req = HTTP::Request->new(POST => $url);
$req->content_type('application/x-www-form-urlencoded');

#contenido del post
$req->content($query);

#contenido de la respuesta
my $response = $ua->request($req);
my $content = $response->content();

print "\n";
print $content;
print "\n";
print "\n";

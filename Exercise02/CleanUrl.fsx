let RemoveHttp (url:string) =
  if url.StartsWith("http://") then
    url.Substring(7)
  else
    url

let RemoveHttps (url:string) =
  if url.StartsWith("https://") then
    url.Substring(8)
  else
    url

let RemoveQueryString (url: string) =
  url.Split("?")[0]

let GetHost url =
  url
  |> RemoveHttp
  |> RemoveHttps
  |> RemoveQueryString